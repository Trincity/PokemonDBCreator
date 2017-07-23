namespace PokemonDbCreator_APIProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixPokemonMovesAndPokemonTypesRelationships : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Moves", "PokemonMove_PokemonMove_id", "dbo.PokemonMove");
            DropForeignKey("dbo.Types", "PokemonType_PokemonType_id", "dbo.PokemonType");
            DropIndex("dbo.Moves", new[] { "PokemonMove_PokemonMove_id" });
            DropIndex("dbo.Types", new[] { "PokemonType_PokemonType_id" });
            AddColumn("dbo.PokemonMove", "Move_id", c => c.Int());
            AddColumn("dbo.PokemonType", "Type_id", c => c.Int());
            CreateIndex("dbo.PokemonMove", "Move_id");
            CreateIndex("dbo.PokemonType", "Type_id");
            AddForeignKey("dbo.PokemonMove", "Move_id", "dbo.Moves", "Move_id");
            AddForeignKey("dbo.PokemonType", "Type_id", "dbo.Types", "Type_id");
            DropColumn("dbo.Moves", "PokemonMove_PokemonMove_id");
            DropColumn("dbo.Types", "PokemonType_PokemonType_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Types", "PokemonType_PokemonType_id", c => c.Int());
            AddColumn("dbo.Moves", "PokemonMove_PokemonMove_id", c => c.Int());
            DropForeignKey("dbo.PokemonType", "Type_id", "dbo.Types");
            DropForeignKey("dbo.PokemonMove", "Move_id", "dbo.Moves");
            DropIndex("dbo.PokemonType", new[] { "Type_id" });
            DropIndex("dbo.PokemonMove", new[] { "Move_id" });
            DropColumn("dbo.PokemonType", "Type_id");
            DropColumn("dbo.PokemonMove", "Move_id");
            CreateIndex("dbo.Types", "PokemonType_PokemonType_id");
            CreateIndex("dbo.Moves", "PokemonMove_PokemonMove_id");
            AddForeignKey("dbo.Types", "PokemonType_PokemonType_id", "dbo.PokemonType", "PokemonType_id");
            AddForeignKey("dbo.Moves", "PokemonMove_PokemonMove_id", "dbo.PokemonMove", "PokemonMove_id");
        }
    }
}
