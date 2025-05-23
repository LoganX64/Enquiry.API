using Microsoft.EntityFrameworkCore;

namespace Enquiry.API.Model
{
    public class EnquiryDBcontext:DbContext
    {
        public EnquiryDBcontext(DbContextOptions<EnquiryDBcontext>options):base(options) { }

        public DbSet<EnquiryStatus> EnquiryStatus { get; set; }

        public DbSet<EnquiryType> EnquiryType { get; set; }

        public DbSet<EnquiryModel> Enquiry { get; set; }
    }
}
