using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Turn.Data;
using Turn.Data.Entities;

namespace Turn.Controllers
{
    public class TicketsController : Controller
    {
        private readonly DataContext _context;

        public TicketsController(DataContext context)
        {
            _context = context;
        }

        // GET: Tickets
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tickets.ToListAsync());
        }
                
        //GET: Tickets/DisplayUnit
        public async Task<IActionResult> DisplayUnit()
        {
            Ticket ticket = await _context.Tickets
                .OrderByDescending(x => x.AttentionDate)
                .FirstOrDefaultAsync(m => m.ServicesType != null);
            return View(ticket);
        }

        // GET: Tickets/Module
        public IActionResult Module()
        {
            return View();
        }

        public async Task<IActionResult> CashDesk1()
        {
            string ST = "CA";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "C 1";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }
        public async Task<IActionResult> CashDesk2()
        {
            string ST = "CA";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "C 2";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }

        public async Task<IActionResult> CashDesk3()
        {
            string ST = "CA";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "C 3";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }

        public async Task<IActionResult> CashDesk4()
        {
            string ST = "CA";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "C 4";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }

        public async Task<IActionResult> CashDesk5()
        {
            string ST = "CA";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "C 5";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }

        public async Task<IActionResult> CashDesk6()
        {
            string ST = "CA";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "C 6";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }

        public async Task<IActionResult> Stand1()
        {
            string ST = "CI";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "V 1";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }

        public async Task<IActionResult> Stand2()
        {
            string ST = "CI";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "V 2";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }

        public async Task<IActionResult> Results1()
        {
            string ST = "ER";
            Ticket ticket = await _context.Tickets.FirstOrDefaultAsync(m => m.ServicesType == ST && m.Stand == null);
            if (ticket == null)
            {
                return NotFound();
            }
            else
            {
                ticket.Stand = "E 1";
                ticket.AttentionDate = DateTime.Now;
                _context.Tickets.Update(ticket);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Module));
        }

        // GET: Tickets/Kiosk
        public IActionResult Kiosk()
        {
            return View();
        }

        // POST: Tickets/Caja
        public async Task<IActionResult> CashDesk()
        {
            string ST = "CA";
            Ticket ticket = await _context.Tickets.OrderByDescending(x => x.Id).FirstOrDefaultAsync(m => m.ServicesType == ST);
            if (ticket == null)
            {
                int SN = 1;
                DateTime datenow = DateTime.Now;
                _context.Tickets.Add(new Ticket { ServicesType = "CA", ShiftNumber = SN, ExpeditionDate = datenow });
            }
            else
            {
                int SN = ticket.ShiftNumber + 1;
                DateTime datenow = DateTime.Now;
                _context.Tickets.Add(new Ticket { ServicesType = "CA", ShiftNumber = SN, ExpeditionDate = datenow });
            }



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Kiosk));
        }

        // POST: Tickets/Stand
        public async Task<IActionResult> Stand()
        {
            string ST = "CI";
            Ticket ticket = await _context.Tickets.OrderByDescending(x => x.Id).FirstOrDefaultAsync(m => m.ServicesType == ST);
            if (ticket == null)
            {
                int SN = 1;
                DateTime datenow = DateTime.Now;
                _context.Tickets.Add(new Ticket { ServicesType = "CI", ShiftNumber = SN, ExpeditionDate = datenow });
            }
            else
            {
                int SN = ticket.ShiftNumber + 1;
                DateTime datenow = DateTime.Now;
                _context.Tickets.Add(new Ticket { ServicesType = "CI", ShiftNumber = SN, ExpeditionDate = datenow });
            }



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Kiosk));
        }

        // POST: Tickets/Results
        public async Task<IActionResult> Results()
        {
            string ST = "ER";
            Ticket ticket = await _context.Tickets.OrderByDescending(x => x.Id).FirstOrDefaultAsync(m => m.ServicesType == ST);
            if (ticket == null)
            {
                int SN = 1;
                DateTime datenow = DateTime.Now;
                _context.Tickets.Add(new Ticket { ServicesType = "ER", ShiftNumber = SN, ExpeditionDate = datenow });
            }
            else
            {
                int SN = ticket.ShiftNumber + 1;
                DateTime datenow = DateTime.Now;
                _context.Tickets.Add(new Ticket { ServicesType = "ER", ShiftNumber = SN, ExpeditionDate = datenow });
            }



            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Kiosk));
        }
             
        // GET: Tickets/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Ticket ticket = await _context.Tickets
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }        
    }
}
