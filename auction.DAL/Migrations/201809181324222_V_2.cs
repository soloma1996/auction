namespace auction.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V_2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            CreateIndex("dbo.AspNetUserRoles", new[] { "RoleId", "UserId" }, unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId", "UserId" });
            CreateIndex("dbo.AspNetUserRoles", "RoleId");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
        }
    }
}
