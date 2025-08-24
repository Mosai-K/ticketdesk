namespace TicketDesk.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDepartmentField : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Department", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tickets", "Department");
        }
    }
}
