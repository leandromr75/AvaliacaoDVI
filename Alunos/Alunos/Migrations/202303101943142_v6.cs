namespace Alunos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Matriculas", "NomeMateria", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Matriculas", "NomeMateria");
        }
    }
}
