using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AppointmentBooking.Models;

namespace AppointmentBooking.Pages.Appointments
{
    public class IndexModel : PageModel
    {
        private readonly AppointmentBooking.Models.ApplicationDbContext _context;

        public IndexModel(AppointmentBooking.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Appointment> Appointment { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Appointments != null)
            {
                Appointment = await _context.Appointments
                .Include(a => a.Client).ToListAsync();
            }
        }
    }
}
