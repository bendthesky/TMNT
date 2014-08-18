namespace TMNT.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTurtles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NinjaTurtles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Weapon = c.String(),
                        Picture = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NinjaTurtles");
        }
    }
}
