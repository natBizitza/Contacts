using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contacts.Models;

    public class ContactsContext : DbContext
    {
        public ContactsContext (DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }

        public DbSet<Contacts.Models.Contact> Contacts { get; set; }
    }
