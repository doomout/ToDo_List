using Npgsql;

public static class DatabaseManager
{
    // PostgreSQL 연결 문자열
    private static string connectionString = "Host=127.0.0.1;Username=doomout;Password=ska258;Database=book_manager";

    // PostgreSQL 연결을 반환하는 메소드
    public static NpgsqlConnection GetConnection()
    {
        // 새로운 연결 객체를 생성하여 반환
        return new NpgsqlConnection(connectionString);
    }

    // 데이터베이스 연결 테스트용 메소드 (필요시 호출)
    public static string TestConnection()
    {
        try
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                return "연결 성공!";
            }
        }
        catch (Exception ex)
        {
            return "연결 실패: " + ex.Message;
        }
    }
}
