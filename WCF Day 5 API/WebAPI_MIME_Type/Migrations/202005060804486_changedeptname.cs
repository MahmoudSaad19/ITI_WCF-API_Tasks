namespace WebAPI_MIME_Type.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedeptname : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DeptName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "DeptName", c => c.Int(nullable: false));
        }
    }
}
