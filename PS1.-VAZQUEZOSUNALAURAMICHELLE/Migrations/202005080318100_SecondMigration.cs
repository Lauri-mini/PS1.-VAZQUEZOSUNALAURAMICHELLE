namespace PS1._VAZQUEZOSUNALAURAMICHELLE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "IdCiudad_Id", c => c.Int());
            CreateIndex("dbo.Events", "IdCiudad_Id");
            AddForeignKey("dbo.Events", "IdCiudad_Id", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "IdCiudad_Id", "dbo.Cities");
            DropIndex("dbo.Events", new[] { "IdCiudad_Id" });
            DropColumn("dbo.Events", "IdCiudad_Id");
        }
    }
}
