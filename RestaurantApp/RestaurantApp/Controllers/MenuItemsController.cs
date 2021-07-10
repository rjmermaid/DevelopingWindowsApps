using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantApp.Data;
using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApp.Controllers
{

        [Authorize(Roles = "Administrator")]
        public class MenuItemsController : Controller
        {
            private readonly ApplicationDbContext _context;

            public MenuItemsController(ApplicationDbContext context)
            {
                _context = context;
            }

            // GET: MenuItems
            public async Task<IActionResult> Index()
            {
                var applicationDbContext = _context.Items.Include(m => m.Category);
                return View(await applicationDbContext.ToListAsync());
            }

            // GET: MenuItems/Details/5
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var menuItem = await _context.Items
                    .Include(m => m.Category)
                    .FirstOrDefaultAsync(m => m.ItemId == id);
                if (menuItem == null)
                {
                    return NotFound();
                }

                return View(menuItem);
            }

            // GET: MenuItems/Create
            public IActionResult Create()
            {
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Description");
                return View();
            }

            // POST: MenuItems/Create
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Create([Bind("ItemId,Name,Price,Description,CategoryId")] Item menuItem)
            {
                if (ModelState.IsValid)
                {
                    _context.Add(menuItem);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Description", menuItem.CategoryId);
                return View(menuItem);
            }

            // GET: MenuItems/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var menuItem = await _context.Items.FindAsync(id);
                if (menuItem == null)
                {
                    return NotFound();
                }
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Description", menuItem.CategoryId);
                return View(menuItem);
            }

            // POST: MenuItems/Edit/5
            // To protect from overposting attacks, enable the specific properties you want to bind to.
            // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> Edit(int id, [Bind("ItemId,Name,Price,Description,CategoryId")] Item menuItem)
            {
                if (id != menuItem.ItemId)
                {
                    return NotFound();
                }

                if (ModelState.IsValid)
                {
                    try
                    {
                        _context.Update(menuItem);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!MenuItemExists(menuItem.ItemId))
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
                ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Description", menuItem.CategoryId);
                return View(menuItem);
            }

            // GET: MenuItems/Delete/5
            public async Task<IActionResult> Delete(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var menuItem = await _context.Items
                    .Include(m => m.Category)
                    .FirstOrDefaultAsync(m => m.ItemId == id);
                if (menuItem == null)
                {
                    return NotFound();
                }

                return View(menuItem);
            }

            // POST: MenuItems/Delete/5
            [HttpPost, ActionName("Delete")]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> DeleteConfirmed(int id)
            {
                var menuItem = await _context.Items.FindAsync(id);
                _context.Items.Remove(menuItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            private bool MenuItemExists(int id)
            {
                return _context.Items.Any(e => e.ItemId == id);
            }
        }
    }


