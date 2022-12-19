using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstateAdCleanArchitecture.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRealEstateAd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RealEstateAds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationLatitude = table.Column<double>(name: "Location_Latitude", type: "float", nullable: false),
                    LocationLongitude = table.Column<double>(name: "Location_Longitude", type: "float", nullable: false),
                    LocationStreet = table.Column<string>(name: "Location_Street", type: "nvarchar(max)", nullable: false),
                    LocationCity = table.Column<string>(name: "Location_City", type: "nvarchar(max)", nullable: false),
                    LocationState = table.Column<string>(name: "Location_State", type: "nvarchar(max)", nullable: false),
                    LocationCountry = table.Column<string>(name: "Location_Country", type: "nvarchar(max)", nullable: false),
                    LocationZipCode = table.Column<string>(name: "Location_ZipCode", type: "nvarchar(max)", nullable: false),
                    PropertyType = table.Column<int>(type: "int", nullable: false),
                    PublicationStatus = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealEstateAds", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RealEstateAds");
        }
    }
}
