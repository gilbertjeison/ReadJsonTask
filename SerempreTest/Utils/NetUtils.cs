using Newtonsoft.Json;
using SerempreTest.Model;

namespace SerempreTest.Utils;

public static class NetUtils
{
    public static async Task<List<User>> GetUserListFromSourceAsync()
    {
        HttpClient client = new();

        var response = await client.GetAsync
            ("https://raw.githubusercontent.com/Serempre/test-json/main/list1.json");
        var strResponse = await response.Content.ReadAsStringAsync();
        List<User> jsonArray = JsonConvert.DeserializeObject<List<User>>(strResponse); 
        return jsonArray;
    }
}
