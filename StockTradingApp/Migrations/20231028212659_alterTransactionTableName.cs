using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockTradingApp.Migrations
{
    /// <inheritdoc />
    public partial class alterTransactionTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transactions_Trades_TradeId",
                table: "transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transactions",
                table: "transactions");

            migrationBuilder.RenameTable(
                name: "transactions",
                newName: "Transactions");

            migrationBuilder.RenameIndex(
                name: "IX_transactions_TradeId",
                table: "Transactions",
                newName: "IX_Transactions_TradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Trades_TradeId",
                table: "Transactions",
                column: "TradeId",
                principalTable: "Trades",
                principalColumn: "TradeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Trades_TradeId",
                table: "Transactions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Transactions",
                table: "Transactions");

            migrationBuilder.RenameTable(
                name: "Transactions",
                newName: "transactions");

            migrationBuilder.RenameIndex(
                name: "IX_Transactions_TradeId",
                table: "transactions",
                newName: "IX_transactions_TradeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_transactions",
                table: "transactions",
                column: "TransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_transactions_Trades_TradeId",
                table: "transactions",
                column: "TradeId",
                principalTable: "Trades",
                principalColumn: "TradeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
