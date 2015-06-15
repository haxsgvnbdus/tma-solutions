namespace PhoneStore.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hanngo : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "CreatedOnUtc", c => c.DateTime());
            AlterColumn("dbo.Product", "UpdatedOnUtc", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "UpdatedOnUtc", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Product", "CreatedOnUtc", c => c.DateTime(nullable: false));
        }
    }
}
