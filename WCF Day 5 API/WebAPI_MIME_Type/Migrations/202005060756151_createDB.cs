namespace WebAPI_MIME_Type.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        DeptName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeptId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        DeptID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DeptID, cascadeDelete: true)
                .Index(t => t.DeptID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DeptID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DeptID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
