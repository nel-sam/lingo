using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cells",
                columns: table => new
                {
                    CellId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<Guid>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cells", x => x.CellId);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Key = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Board",
                columns: table => new
                {
                    BoardId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Key = table.Column<Guid>(type: "TEXT", nullable: false),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false),
                    GameId = table.Column<int>(type: "INTEGER", nullable: false),
                    CellId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board", x => x.BoardId);
                    table.ForeignKey(
                        name: "FK_Board_Cells_CellId",
                        column: x => x.CellId,
                        principalTable: "Cells",
                        principalColumn: "CellId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Board_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Board_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayer",
                columns: table => new
                {
                    GamesGameId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayersPlayerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayer", x => new { x.GamesGameId, x.PlayersPlayerId });
                    table.ForeignKey(
                        name: "FK_GamePlayer_Game_GamesGameId",
                        column: x => x.GamesGameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayer_Players_PlayersPlayerId",
                        column: x => x.PlayersPlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BoardCells",
                columns: table => new
                {
                    BoardId = table.Column<int>(type: "INTEGER", nullable: false),
                    CellId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoardCells", x => new { x.BoardId, x.CellId });
                    table.ForeignKey(
                        name: "FK_BoardCells_Board_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Board",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BoardCells_Cells_CellId",
                        column: x => x.CellId,
                        principalTable: "Cells",
                        principalColumn: "CellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayerBoard",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerId = table.Column<int>(type: "INTEGER", nullable: false),
                    BoardId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayerBoard", x => new { x.GameId, x.PlayerId, x.BoardId });
                    table.ForeignKey(
                        name: "FK_GamePlayerBoard_Board_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Board",
                        principalColumn: "BoardId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayerBoard_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlayerBoard_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 1, "https://media.nature.com/lw800/magazine-assets/d41586-020-01430-5/d41586-020-01430-5_17977552.jpg", new Guid("14943241-3721-4abf-8977-36290b0437ec") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 14, "https://media.architecturaldigest.com/photos/55f9e3f09bff6eeb3a244061/master/w_1600%2Cc_limit/dam-images-shopping-2014-07-bicycles-01-martone.jpg", new Guid("99943241-0d23-406e-8d4d-82fac76066eb") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 13, "https://cdn.shopify.com/s/files/1/0550/6737/products/ORANGEWOOD_ECHO_SPRUCE_SOLID_TOP_DREADNAUGHT_ACOUSTIC_GUITAR-2_1200x.png?v=1604963852", new Guid("33248303-0d23-406e-8d4d-82fac76066eb") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 12, "https://cottagelife.com/wp-content/uploads/2019/12/zebra-foal.jpeg", new Guid("2400c172-0d23-406e-8d4d-82fac76066eb") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 11, "https://www.motortrend.com/uploads/sites/5/2020/01/2020-Acura-NSX-front-three-quarters.jpg", new Guid("4a3a3aa0-0d23-406e-8d4d-82fac76066eb") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 10, "https://post.healthline.com/wp-content/uploads/2019/04/Weed_Orange_1200x628-facebook.jpg", new Guid("f39c648e-04c7-4c5a-a31a-6cf544a9f9d1") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 8, "https://cdn.theathletic.com/app/uploads/2019/09/06104502/GettyImages-1165481703-e1567781166557-1024x684.jpg", new Guid("3400c172-faa7-4e73-894c-dfa68e2e27b9") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 9, "https://cdn.vox-cdn.com/thumbor/1mxkqqttp-h6NTQ9fF6wbcXMcdg=/12x0:4907x3263/1400x1050/filters:focal(12x0:4907x3263):format(jpeg)/cdn.vox-cdn.com/uploads/chorus_image/image/49388585/16071828377_85109fdee4_o.0.0.jpg", new Guid("261c7359-7b71-4a24-a5eb-9e35b62cb823") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 6, "https://mk0mexiconewsdam2uje.kinstacdn.com/wp-content/uploads/2015/12/quetzal-flying-mejor.jpg", new Guid("12d52cf2-bf5f-414c-99f8-ab0364324557") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 5, "https://www.sportsnet.ca/wp-content/uploads/2020/08/Lionel-Messi-Barcelona-Champions-League-1040x572.jpg", new Guid("82696bf9-ff87-46c3-a4de-035177574f47") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 4, "https://static.independent.co.uk/s3fs-public/thumbnails/image/2015/10/07/23/web-ali-g-getty.jpg?width=1200", new Guid("ef1a7514-74e1-45b8-89ff-1495c24fc169") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 3, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/paulo-bent-ply-leather-chair-o-1582926567.jpg", new Guid("12248303-2ec4-4afc-b6a8-8d1498c6601e") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 2, "https://blog.consumerguide.com/wp-content/uploads/sites/2/2018/04/Honda-N-Box.png", new Guid("44777ac2-8f97-4f97-9f33-95c245151fb3") });

            migrationBuilder.InsertData(
                table: "Cells",
                columns: new[] { "CellId", "ImageUrl", "Key" },
                values: new object[] { 7, "https://static01.nyt.com/images/2020/09/25/sports/25soccer-nationalWEB1/merlin_177451008_91c7b66d-3c8a-4963-896e-54280f374b6d-articleLarge.jpg?quality=75&auto=webp&disable=upscale", new Guid("06075c76-4361-4dd5-93eb-a80a28d7ab65") });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Key" },
                values: new object[] { 1, new Guid("5d516a2b-9722-481c-b98e-89831ae4a732") });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "FirstName", "Key", "LastName" },
                values: new object[] { 1, "Nelson", new Guid("5d516a2b-9722-481c-b98e-89831ae4a732"), "Samayoa" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "FirstName", "Key", "LastName" },
                values: new object[] { 2, "Bayron", new Guid("5d526a2b-9722-481c-b98e-89831ae4a732"), "Pineda" });

            migrationBuilder.InsertData(
                table: "Board",
                columns: new[] { "BoardId", "CellId", "GameId", "Key", "PlayerId" },
                values: new object[] { 1, null, 0, new Guid("126963f9-ff87-46c3-a4de-035177574f47"), 1 });

            migrationBuilder.InsertData(
                table: "Board",
                columns: new[] { "BoardId", "CellId", "GameId", "Key", "PlayerId" },
                values: new object[] { 2, null, 0, new Guid("226363f9-ff87-46c3-a4de-035177574f47"), 2 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 10 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 9 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 8 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 7 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 6 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 5 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 14 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 9 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 8 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 7 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 6 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 5 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 4 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 11 });

            migrationBuilder.InsertData(
                table: "BoardCells",
                columns: new[] { "BoardId", "CellId" },
                values: new object[] { 2, 13 });

            migrationBuilder.InsertData(
                table: "GamePlayerBoard",
                columns: new[] { "BoardId", "GameId", "PlayerId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "GamePlayerBoard",
                columns: new[] { "BoardId", "GameId", "PlayerId" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Board_CellId",
                table: "Board",
                column: "CellId");

            migrationBuilder.CreateIndex(
                name: "IX_Board_GameId",
                table: "Board",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Board_PlayerId",
                table: "Board",
                column: "PlayerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BoardCells_CellId",
                table: "BoardCells",
                column: "CellId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayer_PlayersPlayerId",
                table: "GamePlayer",
                column: "PlayersPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayerBoard_BoardId",
                table: "GamePlayerBoard",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlayerBoard_PlayerId",
                table: "GamePlayerBoard",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoardCells");

            migrationBuilder.DropTable(
                name: "GamePlayer");

            migrationBuilder.DropTable(
                name: "GamePlayerBoard");

            migrationBuilder.DropTable(
                name: "Board");

            migrationBuilder.DropTable(
                name: "Cells");

            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
