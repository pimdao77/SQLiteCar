using System;
using SQLite;

namespace SQLiteCar;

public class Constants
{
 private const string DBFileName = "SQLiteCar.db3";

    public const SQLiteOpenFlags Flags = 
                        SQLiteOpenFlags.ReadWrite |
                        SQLiteOpenFlags.Create | 
                        SQLiteOpenFlags.SharedCache;

    public static string DatabasePath {
        get{
            return Path.Combine(FileSystem.AppDataDirectory , DBFileName);
        }
    }
}
