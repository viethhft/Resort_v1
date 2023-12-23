using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Resort.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Convenients",
                columns: table => new
                {
                    IdConvenient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Convenients", x => x.IdConvenient);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    IdProvince = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.IdProvince);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    IdService = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameService = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.IdService);
                });

            migrationBuilder.CreateTable(
                name: "TypeRooms",
                columns: table => new
                {
                    IdTypeRoom = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeRooms", x => x.IdTypeRoom);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    IdDistrict = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProvince = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.IdDistrict);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_IdProvince",
                        column: x => x.IdProvince,
                        principalTable: "Provinces",
                        principalColumn: "IdProvince",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdRole = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                    table.ForeignKey(
                        name: "FK_Users_Roles_IdRole",
                        column: x => x.IdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communes",
                columns: table => new
                {
                    IdCommune = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdDistrict = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communes", x => x.IdCommune);
                    table.ForeignKey(
                        name: "FK_Communes_Districts_IdDistrict",
                        column: x => x.IdDistrict,
                        principalTable: "Districts",
                        principalColumn: "IdDistrict",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    IdUserDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageProfile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.IdUserDetail);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resorts",
                columns: table => new
                {
                    IdResort = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IdCommune = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resorts", x => x.IdResort);
                    table.ForeignKey(
                        name: "FK_Resorts_Communes_IdCommune",
                        column: x => x.IdCommune,
                        principalTable: "Communes",
                        principalColumn: "IdCommune",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Resorts_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser");
                });

            migrationBuilder.CreateTable(
                name: "ConvenientResorts",
                columns: table => new
                {
                    IdConvenient = table.Column<int>(type: "int", nullable: false),
                    IdResort = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConvenientResorts", x => new { x.IdConvenient, x.IdResort });
                    table.ForeignKey(
                        name: "FK_ConvenientResorts_Convenients_IdConvenient",
                        column: x => x.IdConvenient,
                        principalTable: "Convenients",
                        principalColumn: "IdConvenient",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConvenientResorts_Resorts_IdResort",
                        column: x => x.IdResort,
                        principalTable: "Resorts",
                        principalColumn: "IdResort",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ImageReviewResorts",
                columns: table => new
                {
                    IdImage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdResort = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageReviewResorts", x => x.IdImage);
                    table.ForeignKey(
                        name: "FK_ImageReviewResorts_Resorts_IdResort",
                        column: x => x.IdResort,
                        principalTable: "Resorts",
                        principalColumn: "IdResort",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    IdResort = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    RateStar = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => new { x.IdUser, x.IdResort });
                    table.ForeignKey(
                        name: "FK_Rates_Resorts_IdResort",
                        column: x => x.IdResort,
                        principalTable: "Resorts",
                        principalColumn: "IdResort",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rates_Users_IdUser",
                        column: x => x.IdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResortDetails",
                columns: table => new
                {
                    IdResortDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdResort = table.Column<int>(type: "int", nullable: false),
                    AddressDetail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResortDetails", x => x.IdResortDetail);
                    table.ForeignKey(
                        name: "FK_ResortDetails_Resorts_IdResort",
                        column: x => x.IdResort,
                        principalTable: "Resorts",
                        principalColumn: "IdResort",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResortDetailServices",
                columns: table => new
                {
                    IdResortDetail = table.Column<int>(type: "int", nullable: false),
                    IdService = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResortDetailServices", x => new { x.IdService, x.IdResortDetail });
                    table.ForeignKey(
                        name: "FK_ResortDetailServices_ResortDetails_IdResortDetail",
                        column: x => x.IdResortDetail,
                        principalTable: "ResortDetails",
                        principalColumn: "IdResortDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResortDetailServices_Services_IdService",
                        column: x => x.IdService,
                        principalTable: "Services",
                        principalColumn: "IdService",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypeRoomResortDetails",
                columns: table => new
                {
                    IdTypeRoom = table.Column<int>(type: "int", nullable: false),
                    IdResortDetail = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeRoomResortDetails", x => new { x.IdTypeRoom, x.IdResortDetail });
                    table.ForeignKey(
                        name: "FK_TypeRoomResortDetails_ResortDetails_IdResortDetail",
                        column: x => x.IdResortDetail,
                        principalTable: "ResortDetails",
                        principalColumn: "IdResortDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeRoomResortDetails_TypeRooms_IdTypeRoom",
                        column: x => x.IdTypeRoom,
                        principalTable: "TypeRooms",
                        principalColumn: "IdTypeRoom",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Communes_IdDistrict",
                table: "Communes",
                column: "IdDistrict");

            migrationBuilder.CreateIndex(
                name: "IX_ConvenientResorts_IdResort",
                table: "ConvenientResorts",
                column: "IdResort");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_IdProvince",
                table: "Districts",
                column: "IdProvince");

            migrationBuilder.CreateIndex(
                name: "IX_ImageReviewResorts_IdResort",
                table: "ImageReviewResorts",
                column: "IdResort");

            migrationBuilder.CreateIndex(
                name: "IX_Rates_IdResort",
                table: "Rates",
                column: "IdResort");

            migrationBuilder.CreateIndex(
                name: "IX_ResortDetails_IdResort",
                table: "ResortDetails",
                column: "IdResort",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResortDetailServices_IdResortDetail",
                table: "ResortDetailServices",
                column: "IdResortDetail");

            migrationBuilder.CreateIndex(
                name: "IX_Resorts_IdCommune",
                table: "Resorts",
                column: "IdCommune");

            migrationBuilder.CreateIndex(
                name: "IX_Resorts_IdUser",
                table: "Resorts",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_TypeRoomResortDetails_IdResortDetail",
                table: "TypeRoomResortDetails",
                column: "IdResortDetail");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_IdUser",
                table: "UserDetails",
                column: "IdUser",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_IdRole",
                table: "Users",
                column: "IdRole",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConvenientResorts");

            migrationBuilder.DropTable(
                name: "ImageReviewResorts");

            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "ResortDetailServices");

            migrationBuilder.DropTable(
                name: "TypeRoomResortDetails");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "Convenients");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "ResortDetails");

            migrationBuilder.DropTable(
                name: "TypeRooms");

            migrationBuilder.DropTable(
                name: "Resorts");

            migrationBuilder.DropTable(
                name: "Communes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
