using Microsoft.EntityFrameworkCore.Migrations;

namespace StreamingTvComparison.Data.Migrations
{
    public partial class ProviderChannel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Channel_Provider_ProviderId",
                table: "Channel");

            migrationBuilder.DropIndex(
                name: "IX_Channel_ProviderId",
                table: "Channel");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Channel");

            migrationBuilder.CreateTable(
                name: "ProviderChannel",
                columns: table => new
                {
                    ProviderId = table.Column<int>(nullable: false),
                    ChannelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderChannel", x => new { x.ProviderId, x.ChannelId });
                    table.ForeignKey(
                        name: "FK_ProviderChannel_Channel_ChannelId",
                        column: x => x.ChannelId,
                        principalTable: "Channel",
                        principalColumn: "ChannelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderChannel_Provider_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Provider",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProviderChannel_ChannelId",
                table: "ProviderChannel",
                column: "ChannelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProviderChannel");

            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "Channel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Channel_ProviderId",
                table: "Channel",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Channel_Provider_ProviderId",
                table: "Channel",
                column: "ProviderId",
                principalTable: "Provider",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
