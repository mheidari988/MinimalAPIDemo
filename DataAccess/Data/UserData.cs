using DataAccess.DbAccess;
using DataAccess.Model;

namespace DataAccess.Data;
public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<IEnumerable<UserModel>> GetUsers() =>
       await _db.LoadData<UserModel, dynamic>("dbo.sp_UserGetAll", new { });

    public async Task<UserModel?> GetUser(int id) =>
        (await _db.LoadData<UserModel, dynamic>("dbo.sp_UserGet", new { Id = id })).FirstOrDefault();

    public async Task InsertUser(UserModel user) =>
        await _db.SaveData("dbo.sp_UserInsert", new { user.FirstName, user.LastName });

    public async Task DeleteUser(int id) =>
        await _db.SaveData("dbo.sp_UserDelete", new { Id = id });
    public async Task UpdateUser(UserModel user) =>
        await _db.SaveData("dbo.sp_UserUpdate", user);
}
