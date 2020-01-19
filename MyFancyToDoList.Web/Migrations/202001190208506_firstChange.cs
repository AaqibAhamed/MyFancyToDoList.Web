namespace MyFancyToDoList.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstChange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ToDoLists", "IsCompleted", c => c.Boolean(nullable: false));
            AddColumn("dbo.ToDoLists", "IsReOccuring", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ToDoLists", "IsReOccuring");
            DropColumn("dbo.ToDoLists", "IsCompleted");
        }
    }
}
