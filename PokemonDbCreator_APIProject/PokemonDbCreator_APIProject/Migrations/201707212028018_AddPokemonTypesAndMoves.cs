namespace PokemonDbCreator_APIProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPokemonTypesAndMoves : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Moves",
                c => new
                    {
                        Move_id = c.Int(nullable: false, identity: true),
                        moveId = c.Int(nullable: false),
                        name = c.String(nullable: false),
                        description = c.String(nullable: false),
                        type = c.Int(nullable: false),
                        category = c.String(nullable: false),
                        contest = c.String(nullable: false),
                        pp = c.Int(nullable: false),
                        power = c.Int(nullable: false),
                        accuracy = c.Int(nullable: false),
                        gen = c.Int(nullable: false),
                        PokemonMove_PokemonMove_id = c.Int(),
                    })
                .PrimaryKey(t => t.Move_id)
                .ForeignKey("dbo.PokemonMove", t => t.PokemonMove_PokemonMove_id)
                .Index(t => t.PokemonMove_PokemonMove_id);
            
            CreateTable(
                "dbo.PokemonMove",
                c => new
                    {
                        PokemonMove_id = c.Int(nullable: false, identity: true),
                        Pokemon_id = c.Int(),
                    })
                .PrimaryKey(t => t.PokemonMove_id)
                .ForeignKey("dbo.Pokemon", t => t.Pokemon_id)
                .Index(t => t.Pokemon_id);
            
            CreateTable(
                "dbo.Pokemon",
                c => new
                    {
                        Pokemon_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false, maxLength: 50),
                        dexNo = c.Int(nullable: false),
                        baseHP = c.Int(nullable: false),
                        baseAttack = c.Int(nullable: false),
                        baseDefense = c.Int(nullable: false),
                        baseSpecialAttack = c.Int(nullable: false),
                        baseSpecialDefense = c.Int(nullable: false),
                        baseSpeed = c.Int(nullable: false),
                        baseTotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pokemon_id);
            
            CreateTable(
                "dbo.PokemonType",
                c => new
                    {
                        PokemonType_id = c.Int(nullable: false, identity: true),
                        Pokemon_id = c.Int(),
                    })
                .PrimaryKey(t => t.PokemonType_id)
                .ForeignKey("dbo.Pokemon", t => t.Pokemon_id)
                .Index(t => t.Pokemon_id);
            
            CreateTable(
                "dbo.Types",
                c => new
                    {
                        Type_id = c.Int(nullable: false, identity: true),
                        type = c.String(nullable: false),
                        PokemonType_PokemonType_id = c.Int(),
                    })
                .PrimaryKey(t => t.Type_id)
                .ForeignKey("dbo.PokemonType", t => t.PokemonType_PokemonType_id)
                .Index(t => t.PokemonType_PokemonType_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PokemonType", "Pokemon_id", "dbo.Pokemon");
            DropForeignKey("dbo.Types", "PokemonType_PokemonType_id", "dbo.PokemonType");
            DropForeignKey("dbo.PokemonMove", "Pokemon_id", "dbo.Pokemon");
            DropForeignKey("dbo.Moves", "PokemonMove_PokemonMove_id", "dbo.PokemonMove");
            DropIndex("dbo.Types", new[] { "PokemonType_PokemonType_id" });
            DropIndex("dbo.PokemonType", new[] { "Pokemon_id" });
            DropIndex("dbo.PokemonMove", new[] { "Pokemon_id" });
            DropIndex("dbo.Moves", new[] { "PokemonMove_PokemonMove_id" });
            DropTable("dbo.Types");
            DropTable("dbo.PokemonType");
            DropTable("dbo.Pokemon");
            DropTable("dbo.PokemonMove");
            DropTable("dbo.Moves");
        }
    }
}
