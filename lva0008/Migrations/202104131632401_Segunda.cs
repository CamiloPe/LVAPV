namespace lva0008.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Segunda : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "LastName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Students", "Photo", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Photo", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
        }
    }
}
