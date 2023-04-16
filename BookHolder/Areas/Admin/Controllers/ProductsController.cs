using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BookHolder.Areas.Admin.Data;
using BookHolder.Areas.Admin.Models;
using BookHolder.Helpper;
using AspNetCoreHero.ToastNotification.Abstractions;
using System.IO;

namespace BookHolder.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly BookholderContext _context;
        public INotyfService _notyfySerice { get; }

        public ProductsController(BookholderContext context, INotyfService notyfySerice)
        {
            _context = context;
            _notyfySerice = notyfySerice;
        }

        // GET: Admin/Products
        public async Task<IActionResult> Index()
        {
            var bookholderContext = _context.Products.Include(p => p.productType);
            return View(await bookholderContext.ToListAsync());
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.productType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // GET: Admin/Products/Create
        public IActionResult Create()
        {
            ViewData["productTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,ShortDesc,Description,CatId,Price,Discount,Thumb,DateCreated,DateModified,BestSellers,HomeFlag,Active,Tags,Title,Alias,MetaDesc,MetaKey,UnitsInStock")] Products products, Microsoft.AspNetCore.Http.IFormFile fThumb)
        {
            if (ModelState.IsValid)
            {

                products.ProductName = Utilities.ToTitleCase(products.ProductName);
                if (fThumb != null)
                {
                    string extension = Path.GetExtension(fThumb.FileName);
                    string image = Utilities.SEOUrl(products.ProductName) + extension;
                    products.image = await Utilities.UploadFile(fThumb, @"products", image.ToLower());
                }
                if (string.IsNullOrEmpty(products.image)) products.image = "default.jpg";
                _notyfySerice.Success("Thêm mới thành công");
                _context.Add(products);
                await _context.SaveChangesAsync();
                
                return RedirectToAction(nameof(Index));
            }

            ViewData["productTypeId"] = new SelectList(_context.ProductTypes, "Id", "Name", products.productTypeId);

            return View(products);
        }

        // GET: Admin/Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products.FindAsync(id);
            if (products == null)
            {
                return NotFound();
            }
            ViewData["productTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id", products.productTypeId);
            return View(products);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductName,image,ImageID,Price,Quantity,Describe,release,author,dateTime,Category,productTypeId,View_Product,Status")] Products products)
        {
            if (id != products.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(products);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductsExists(products.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["productTypeId"] = new SelectList(_context.ProductTypes, "Id", "Id", products.productTypeId);
            return View(products);
        }

        // GET: Admin/Products/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var products = await _context.Products
                .Include(p => p.productType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (products == null)
            {
                return NotFound();
            }

            return View(products);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var products = await _context.Products.FindAsync(id);
            _context.Products.Remove(products);
            await _context.SaveChangesAsync();
            _notyfySerice.Success("Xóa Sản Phẩm công");
            return RedirectToAction(nameof(Index));
        }

        private bool ProductsExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
