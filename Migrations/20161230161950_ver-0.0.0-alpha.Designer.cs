using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using todoAPI;

namespace netCore_todoAPI_ef.Migrations
{
    [DbContext(typeof(todoContext))]
    [Migration("20161230161950_ver-0.0.0-alpha")]
    partial class ver000alpha
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ChangeDetector.SkipDetectChanges", "true")
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");
        }
    }
}
