using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Punk_Stocks.Data
{
    internal class DatabaseInitializer
    {
        public static void Initialize()
        {
            using var connection = Database.GetConnection();
            using var cmd = connection.CreateCommand();

            cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    user_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT NOT NULL UNIQUE,
                    password_hash TEXT NOT NULL,
                    cash_balance REAL NOT NULL DEFAULT 0,
                    theme TEXT NOT NULL DEFAULT 'Light',
                    language TEXT NOT NULL DEFAULT 'en',
                    is_admin INTEGER NOT NULL DEFAULT 0,
                    created_at TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS Stocks (
                    stock_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    symbol TEXT NOT NULL UNIQUE,
                    company_name TEXT NOT NULL,
                    sector TEXT NOT NULL,
                    current_price REAL NOT NULL CHECK (current_price > 0),
                    volatility REAL NOT NULL DEFAULT 0.02,
                    dividend_yield REAL NOT NULL DEFAULT 0
                );

                CREATE TABLE IF NOT EXISTS Holdings (
                    holding_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER NOT NULL REFERENCES Users(user_id) ON DELETE CASCADE,
                    stock_id INTEGER NOT NULL REFERENCES Stocks(stock_id),
                    quantity INTEGER NOT NULL CHECK (quantity > 0),
                    avg_cost REAL NOT NULL,
                    UNIQUE (user_id, stock_id)
                );

                CREATE TABLE IF NOT EXISTS Transactions (
                    transaction_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER NOT NULL REFERENCES Users(user_id) ON DELETE CASCADE,
                    stock_id INTEGER NOT NULL REFERENCES Stocks(stock_id),
                    type TEXT NOT NULL CHECK (type IN ('BUY','SELL')),
                    quantity INTEGER NOT NULL CHECK (quantity > 0),
                    price_per_share REAL NOT NULL,
                    executed_at TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS Watchlist (
                    watchlist_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER NOT NULL REFERENCES Users(user_id) ON DELETE CASCADE,
                    stock_id INTEGER NOT NULL REFERENCES Stocks(stock_id),
                    added_at TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP,
                    UNIQUE (user_id, stock_id)
                );

                CREATE TABLE IF NOT EXISTS Alerts (
                    alert_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER NOT NULL REFERENCES Users(user_id) ON DELETE CASCADE,
                    stock_id INTEGER NOT NULL REFERENCES Stocks(stock_id),
                    target_price REAL NOT NULL,
                    direction TEXT NOT NULL CHECK (direction IN ('ABOVE','BELOW')),
                    is_triggered INTEGER NOT NULL DEFAULT 0
                );

                CREATE TABLE IF NOT EXISTS PriceHistory (
                    price_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    stock_id INTEGER NOT NULL REFERENCES Stocks(stock_id),
                    price REAL NOT NULL,
                    recorded_at TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP
                );

                CREATE TABLE IF NOT EXISTS Dividends (
                    dividend_id INTEGER PRIMARY KEY AUTOINCREMENT,
                    user_id INTEGER NOT NULL REFERENCES Users(user_id) ON DELETE CASCADE,
                    stock_id INTEGER NOT NULL REFERENCES Stocks(stock_id),
                    amount REAL NOT NULL,
                    paid_at TEXT NOT NULL DEFAULT CURRENT_TIMESTAMP
                );";

            cmd.ExecuteNonQuery();
        }
    }
}
