// See https://aka.ms/new-console-template for more information

using qushuiying;
using qushuiying.model;
using SqlSugar;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;

//List<sheel1> listA;
//List<sheel1> listB;

//List<sheel1> listResult;


//string con = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../excel/A网站热门景点.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'";

//using (OleDbConnection connection = new OleDbConnection(con))
//{
//    connection.Open();
//    OleDbCommand command = new OleDbCommand("select * from [sheel1$]", connection);
//    using (OleDbDataReader dr = command.ExecuteReader())
//    {
//        List<sheel1> list = new List<sheel1>();
//        while (dr.Read())
//        {
//            sheel1 sheel1 = new sheel1()
//            {
//                sheng = dr[0].ToString(),
//                shi = dr[1].ToString(),
//                qu = dr[2].ToString(),
//                name = dr[3].ToString(),
//                scenicid = dr[4].ToString(),
//                leixing = dr[5].ToString(),
//                jibie = dr[6].ToString(),
//                redu = dr[7].ToString(),
//                dizhi = dr[8].ToString(),
//                tese = dr[9].ToString(),
//                jindu = dr[10].ToString(),
//                weidu = dr[11].ToString()
//            };
//            list.Add(sheel1);
//        }
//        string[] typestr = new string[] { "博物馆", "城市观光","公园", "古建筑", "古镇", "故居", "陵墓陵园", "山川", "寺庙", "文化古迹", "遗址", "园林", "自然风光", "宗教" };
//        listA = list.GroupBy(m => new { m.sheng, m.shi, m.name })
//                .Select(m => m.First())
//                .Where(m=>typestr.Contains(m.leixing))
//                .ToList();

//        Console.WriteLine(listA.Count);
//    }
//}

//string con1 = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../../excel/A级景区.xlsx;Extended Properties='Excel 12.0 Xml;HDR=YES;'";

//using (OleDbConnection connection = new OleDbConnection(con1))
//{
//    connection.Open();
//    OleDbCommand command = new OleDbCommand("select * from [sheel1$]", connection);

//    using (OleDbDataReader dr = command.ExecuteReader())
//    {
//        List<sheel1> list = new List<sheel1>();
//        while (dr.Read())
//        {
//            sheel1 sheel1 = new sheel1()
//            {
//                name = dr[0].ToString(),
//                sheng = dr[1].ToString(),
//                jibie = dr[2].ToString(),
//                jindu = dr[3].ToString(),
//                weidu = dr[4].ToString(),
//            };
//            list.Add(sheel1);
//        }

//        listB = list.GroupBy(m => new { m.sheng, m.name })
//                .Select(m => m.First())
//                .ToList();

//        Console.WriteLine(listB.Count);
//    }



//}

//listResult=listA.Concat(listB).ToList();

//List<sheel1> Resultdistinct=listResult.GroupBy(m => new { m.sheng, m.name })
//                .Select(m => m.First())
//                .ToList();

//Console.WriteLine(Resultdistinct.Count);



//SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
//{
//    ConnectionString = "Data Source=106.12.58.227;port=3306;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=Required;AllowLoadLocalInfile=true;",
//    //ConnectionString = "Data Source=120.48.101.54;port=3308;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=none;AllowLoadLocalInfile=true; ",
//    DbType = DbType.MySql, // 设置数据库类型
//    IsAutoCloseConnection = true,
//    InitKeyType = InitKeyType.Attribute
//});

//List<province> provinces = db.Ado.SqlQuery<province>("SELECT ProvinceCode as value, ProvinceName as data FROM data_province ");




//List<Scinsert> scinserts = Resultdistinct.Select(m =>
//{
//    var province = provinces.FirstOrDefault(p => p.data.Contains( m.sheng?.Trim()));
//    return new Scinsert
//    {
//        Scname = m.name?.Trim(),
//        Scaddress = m.dizhi?.Trim(),
//        Zuobiao = m.jindu?.Trim() + "," + m.weidu?.Trim(),
//        Province = province != null ? province.value : null
//    };
//}).ToList();

//Console.WriteLine(scinserts[0].Province);
//db.Fastest<Scinsert>().BulkCopy(scinserts);






//SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
//{
//    ConnectionString = "Data Source=106.12.58.227;port=3306;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=Required;AllowLoadLocalInfile=true;",
//    //ConnectionString = "Data Source=120.48.101.54;port=3308;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=none;AllowLoadLocalInfile=true; ",
//    DbType = DbType.MySql, // 设置数据库类型
//    IsAutoCloseConnection = true,
//    InitKeyType = InitKeyType.Attribute
//});

//List<Scinsert> provinces = db.Queryable<Scinsert>().Where(m => m.Scmainurl != null && m.sccarouselurl != null).ToList();

//List<TravelCommonLocationsModel> locationList = new List<TravelCommonLocationsModel>();
//List<TravelStoresModel> travelStoresList = new List<TravelStoresModel>();
//List<TravelScenicSpotsModel> travelScenicList = new List<TravelScenicSpotsModel>();
//List<TravelScenicImageModel> img = new List<TravelScenicImageModel>();
//SnowFlakeSingle.WorkId = 2;
//foreach (Scinsert sc in provinces)
//{
//    long commonid = SnowFlakeSingle.Instance.NextId();

//    TravelCommonLocationsModel locationModel = new TravelCommonLocationsModel
//    {
//        Commonid = commonid,
//        Common_name = sc.Scname,
//        Description = sc.Scremark,
//        Address = sc.Scaddress,
//        Status = 2,
//        Location_type = 0,
//        LongiLatitude = sc.Zuobiao,
//        Image_url = sc.Scmainurl,
//        Create_time = DateTime.Now,
//        Update_time = DateTime.Now,
//        Is_paid_promotion = "N",
//        Likes = 0,
//        City = sc.Province,
//        Userid = -1

//    };
//    locationList.Add(locationModel);

//    long storesid = SnowFlakeSingle.Instance.NextId();
//    TravelStoresModel travelStoresModel = new TravelStoresModel
//    {
//        Storesid = storesid,
//        Stores_description = sc.Scname,
//        Stores_name = sc.Scname,
//        Stores_type = 0
//    };
//    travelStoresList.Add(travelStoresModel);
//    long scenicid = SnowFlakeSingle.Instance.NextId();

//    TravelScenicSpotsModel travelScenic = new TravelScenicSpotsModel
//    {
//        spotsid = scenicid,
//        location_id = commonid,
//        status = 2,
//        opening_hours = sc.Scopentime,
//        suggest_time = sc.Scplaytime,
//        optimum_time = sc.Scplaygoodtime,
//        create_time = DateTime.Now,
//        update_time = DateTime.Now,
//        stores_id = storesid
//    };

//    travelScenicList.Add(travelScenic);

//    string[] carouseurl = sc.sccarouselurl.Split(',');

//    foreach (string car in carouseurl)
//    {
//        TravelScenicImageModel scenicImageModel = new TravelScenicImageModel
//        {
//            travel_scenic_imageid = SnowFlakeSingle.Instance.NextId(),
//            travel_scenicid = scenicid,
//            imageurl = car
//        };
//        img.Add(scenicImageModel);
//    }


//}



//SqlSugarClient db1 = new SqlSugarClient(new ConnectionConfig()
//{
//    ConnectionString = "Data Source=106.12.58.227;port=3306;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=Required;AllowLoadLocalInfile=true;",
//    //ConnectionString = "Data Source=120.48.101.54;port=3308;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=none;AllowLoadLocalInfile=true; ",
//    DbType = DbType.MySql, // 设置数据库类型
//    IsAutoCloseConnection = true,
//    InitKeyType = InitKeyType.Attribute
//});




//Console.WriteLine("可用景区：" + locationList.Count);
//Console.WriteLine("可用图片：" + img.Count);
//db1.Fastest<TravelCommonLocationsModel>().BulkCopy(locationList);
//db1.Fastest<TravelScenicImageModel>().BulkCopy(img);
//db1.Fastest<TravelStoresModel>().BulkCopy(travelStoresList);
//db1.Fastest<TravelScenicSpotsModel>().BulkCopy(travelScenicList);
//Console.WriteLine("插入完成");
//Console.Read();










//SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
//{
//    ConnectionString = "Data Source=106.12.58.227;port=3306;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=Required;AllowLoadLocalInfile=true;",
//    //ConnectionString = "Data Source=120.48.101.54;port=3308;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=none;AllowLoadLocalInfile=true; ",
//    DbType = DbType.MySql, // 设置数据库类型
//    IsAutoCloseConnection = true,
//    InitKeyType = InitKeyType.Attribute
//});

//List<TravelCommonLocationsModel> travelCommonLocationsModel = db.Queryable<TravelCommonLocationsModel>().ToList();
//SnowFlakeSingle.WorkId = 2;

//// 1. 将数据按城市分组
//var groupedByCity = travelCommonLocationsModel.GroupBy(t => t.City);

//List<TravelHotListModel> hotListToInsert = new List<TravelHotListModel>();

//foreach (var cityGroup in groupedByCity)
//{
//    // 2. 对于每个城市随机选择10个位置
//    var selectedLocations = cityGroup.OrderBy(x => Guid.NewGuid()).Take(10).ToList();

//    int orderNum = 0;
//    foreach (var location in selectedLocations)
//    {
//        hotListToInsert.Add(new TravelHotListModel()
//        {
//            Hotlistid = SnowFlakeSingle.Instance.NextId(),
//            Locationid = location.Commonid,  // Assuming the location model has an 'id' property
//            Type = 0,
//            citycode = cityGroup.Key,
//            Order_num = orderNum++,
//            imageurl = null  // Setting imageurl to null as per your instruction
//        });
//    }
//}
//// 3. 使用SqlSugar插入数据
//db.Insertable(hotListToInsert).ExecuteCommand();


//-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

//SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
//{
//    //ConnectionString = "Data Source=106.12.58.227;port=3306;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=Required;AllowLoadLocalInfile=true;",
//    ConnectionString = "Data Source=120.48.101.54;port=3308;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=none;AllowLoadLocalInfile=true; ",
//    DbType = DbType.MySql, // 设置数据库类型
//    IsAutoCloseConnection = true,
//    InitKeyType = InitKeyType.Attribute
//});

//List<data_city> citylist = db.Context.Queryable<data_city>().ToList();
//List<data_province> provinceslist = db.Context.Queryable<data_province>().ToList();


//int pageindex = 1;
//var client = new HttpClient();
//List<ScenicLocation> ScenicList = new();
//List<TicketDetailData> TicketsList = new List<TicketDetailData>();


//List<TravelPanheScenic> panheScenics = new List<TravelPanheScenic>();
//List<TravelPanheTicketDetail> panheTicketDetails = new List<TravelPanheTicketDetail>();



//while (true)
//{

//    var request = new HttpRequestMessage
//    {
//        Method = HttpMethod.Get,
//        RequestUri = new Uri($"http://api.panhe.net/ticket/searchScenicList?appKey=fcf5707d61055707a3c7db4b9b1514d0&country=中国&PageIndex={pageindex}&PageSize=50"),
//    };
//    using (var response = await client.SendAsync(request))
//    {
//        response.EnsureSuccessStatusCode();
//        var body = await response.Content.ReadAsStringAsync();
//        ScenicLocationRoot scenicLocation = JsonSerializer.Deserialize<ScenicLocationRoot>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
//        if (scenicLocation.Success && scenicLocation.Data.ScenicList.Count > 0)
//        {
//            ScenicList.AddRange(scenicLocation.Data.ScenicList);
//            pageindex++;
//            Console.WriteLine("景区数量：" + ScenicList.Count);
//        }
//        else
//        {
//            break;
//        }
//    }
//}

//Console.WriteLine("景区获取完成！");
//var DistinctList = ScenicList.GroupBy(m => m.ScenicId)
//                                                                .Select(group => group.First())
//                                                                .ToList();

//for (int i = 0; i < DistinctList.Count; i++)
//{

//    try
//    {



//        if (string.IsNullOrEmpty(DistinctList[i].ProvinceName))
//        {
//            Console.WriteLine($"国外数据：城市为 {DistinctList[i].CityName}");
//            continue;
//        }
//        //data_city? data_City = citylist.Find(m => m.CityName.Contains(DistinctList[i].CityName));
//        //data_province? data_province = provinceslist.Find(m => m.ProvinceName.Contains(DistinctList[i].ProvinceName));
//        TravelPanheScenic travelPanheScenic = new TravelPanheScenic()
//        {
//            ScenicDescription = DistinctList[i].ScenicDescription,
//            Scenicid = long.Parse(DistinctList[i].ScenicId),
//            ScenicName = DistinctList[i].ScenicName,
//            Star = DistinctList[i].Star,
//            CommentScore = DistinctList[i].CommentScore,
//            Address = DistinctList[i].Address,
//            BookNotice = DistinctList[i].BookNotice,
//            Images = String.Join(",", DistinctList[i].Images ?? new string[0]),
//            Latitude = DistinctList[i].Latitude,
//            Longitude = DistinctList[i].Longitude,
//            MainImage = DistinctList[i].MainImage,
//            OpenTime = DistinctList[i].OpenTime,
//            Recommend = DistinctList[i].Recommand,
//            ThemeGroups = DistinctList[i].ThemeGroups,
//            // CityCode = data_City == null ? DistinctList[i].CityName : data_City.CityCode,
//             CityCode = DistinctList[i].CityName,
//            //ProvinceCode = data_province == null ? DistinctList[i].ProvinceName : data_province.ProvinceCode,
//            ProvinceCode = DistinctList[i].ProvinceName,
//            MinPrice = DistinctList[i].TicketProducts.Any() ? DistinctList[i].TicketProducts.Min(m => decimal.Parse(m.SettlePrice)).ToString():"0"

//        };
//        panheScenics.Add(travelPanheScenic);




//        for (int j = 0; j < DistinctList[i].TicketProducts.Count; j++)
//        {

//            TravelPanheTicketDetail travelPanheTicketDetail = new TravelPanheTicketDetail()
//            {
//                ScenicId = long.Parse(DistinctList[i].ScenicId),
//                SettlePrice = DistinctList[i].TicketProducts[j].SettlePrice,

//                MarketPrice = DistinctList[i].TicketProducts[j].MarketPrice,

//                ProductId = long.Parse(DistinctList[i].TicketProducts[j].ProductId),
//                ProductName = DistinctList[i].TicketProducts[j].ProductName,

//            };

//            panheTicketDetails.Add(travelPanheTicketDetail);

//        }



//    }
//    catch (Exception ex)
//    {
//        throw new Exception(ex.Message);
//    }



//}







//=======================================================================================================================================================================================

SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
{
    ConnectionString = "Data Source=106.12.58.227;port=3306;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=Required;AllowLoadLocalInfile=true;",
    //ConnectionString = "Data Source=120.48.101.54;port=3308;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=none;AllowLoadLocalInfile=true; ",
    DbType = DbType.MySql, // 设置数据库类型
    IsAutoCloseConnection = true,
    InitKeyType = InitKeyType.Attribute
});

List<data_city> citylist = db.Context.Queryable<data_city>().ToList();
List<data_province> provinceslist = db.Context.Queryable<data_province>().ToList();


var client = new HttpClient();
List<ScenicLocation> ScenicList = new();
List<TicketDetailData> TicketsList = new List<TicketDetailData>();


List<TravelPanheScenic> panheScenics = new List<TravelPanheScenic>();
List<TravelPanheTicketDetail> panheTicketDetails = new List<TravelPanheTicketDetail>();





foreach (var item in citylist)
{
    int pageindex = 1;

    while (true)
    {

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri($"http://openapi.shpanhe.com/ticket/searchScenicList?appKey=54ec4c14d376b3405412913857ed1365&country=中国&PageIndex={pageindex}&PageSize=50&cityname={item.CityName}&isExistAvailableSaleProduct=1"),
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            ScenicLocationRoot scenicLocation = JsonSerializer.Deserialize<ScenicLocationRoot>(body, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            if (scenicLocation.Success && scenicLocation.Data.ScenicList.Count > 0)
            {
                scenicLocation.Data.ScenicList.ForEach(x =>
                {
                    x.CityName = item.CityCode;
                    x.ProvinceName = item.ProvinceCode;
                });
                ScenicList.AddRange(scenicLocation.Data.ScenicList);
                pageindex++;
                Console.WriteLine("景区数量：" + ScenicList.Count);
            }
            else
            {
                break;
            }
        }
        Thread.Sleep(1000);
    }
}


Console.WriteLine("景区获取完成！");
var DistinctList = ScenicList.GroupBy(m => m.ScenicId)
                                                                .Select(group => group.First())
                                                                .ToList();

for (int i = 0; i < DistinctList.Count; i++)
{

    try
    {



        if (string.IsNullOrEmpty(DistinctList[i].ProvinceName))
        {
            Console.WriteLine($"国外数据：城市为 {DistinctList[i].CityName}");
            continue;
        }
        //data_city? data_City = citylist.Find(m => m.CityName.Contains(DistinctList[i].CityName));
        //data_province? data_province = provinceslist.Find(m => m.ProvinceName.Contains(DistinctList[i].ProvinceName));
        TravelPanheScenic travelPanheScenic = new TravelPanheScenic()
        {
            ScenicDescription = DistinctList[i].ScenicDescription,
            Scenicid = long.Parse(DistinctList[i].ScenicId),
            ScenicName = DistinctList[i].ScenicName,
            Star = DistinctList[i].Star,
            CommentScore = DistinctList[i].CommentScore,
            Address = DistinctList[i].Address,
            BookNotice = DistinctList[i].BookNotice,
            Images = String.Join(",", DistinctList[i].Images ?? new string[0]),
            Latitude = DistinctList[i].Latitude,
            Longitude = DistinctList[i].Longitude,
            MainImage = DistinctList[i].MainImage,
            OpenTime = DistinctList[i].OpenTime,
            Recommend = DistinctList[i].Recommand,
            ThemeGroups = DistinctList[i].ThemeGroups,
            // CityCode = data_City == null ? DistinctList[i].CityName : data_City.CityCode,
            CityCode = DistinctList[i].CityName,
            //ProvinceCode = data_province == null ? DistinctList[i].ProvinceName : data_province.ProvinceCode,
            ProvinceCode = DistinctList[i].ProvinceName,
            MinPrice = DistinctList[i].TicketProducts.Any() ? DistinctList[i].TicketProducts.Min(m => decimal.Parse(m.SettlePrice)).ToString() : "0"

        };
        panheScenics.Add(travelPanheScenic);




        for (int j = 0; j < DistinctList[i].TicketProducts.Count; j++)
        {

            TravelPanheTicketDetail travelPanheTicketDetail = new TravelPanheTicketDetail()
            {
                ScenicId = long.Parse(DistinctList[i].ScenicId),
                SettlePrice = DistinctList[i].TicketProducts[j].SettlePrice,

                MarketPrice = DistinctList[i].TicketProducts[j].MarketPrice,

                ProductId = long.Parse(DistinctList[i].TicketProducts[j].ProductId),
                ProductName = DistinctList[i].TicketProducts[j].ProductName,

            };

            panheTicketDetails.Add(travelPanheTicketDetail);

        }



    }
    catch (Exception ex)
    {
        throw new Exception(ex.Message);
    }



}























Console.WriteLine("景区数：" + panheScenics.Count);
Console.WriteLine("总票数：" + panheTicketDetails.Count);

db.Fastest<TravelPanheScenic>().BulkCopy(panheScenics);
db.Fastest<TravelPanheTicketDetail>().BulkCopy(panheTicketDetails);

Console.WriteLine("插入完成！");

Console.ReadKey();
















//SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
//{
//    ConnectionString = "Data Source=106.12.58.227;port=3306;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=Required;AllowLoadLocalInfile=true;",
//    //ConnectionString = "Data Source=120.48.101.54;port=3308;User ID=root;Password=******;Database=travel;CharSet=utf8;sslmode=none;AllowLoadLocalInfile=true; ",
//    DbType = DbType.MySql, // 设置数据库类型
//    IsAutoCloseConnection = true,
//    InitKeyType = InitKeyType.Attribute
//});


//List<TravelUserModel> models = db.Queryable<TravelUserModel>().ToList();
//MD5 md5 = MD5.Create();
//models.ForEach(model =>
//{
//      model.User_phone =string.IsNullOrEmpty(model.User_phone)? model.User_phone: CalculateMD5Hash(model.User_phone);
//    //model.Emergency_phone = string.IsNullOrEmpty(model.Emergency_phone) ? model.Emergency_phone : Encrypt(model.Emergency_phone, "b4f2c9a8d13e5678fa9bced1f34e2d56");
//     //model.Emergency_contact = string.IsNullOrEmpty(model.Emergency_contact) ? model.Emergency_contact : Encrypt(model.Emergency_contact, "b4f2c9a8d13e5678fa9bced1f34e2d56");
//     //model.User_phone = string.IsNullOrEmpty(model.User_phone) ? model.User_phone : Decrypt(model.User_phone, "9m28w4Df6JkL3fTgZ7qVx2H0NtYc5pQb");

//});

//db.Updateable(models).ExecuteCommand();

/// <summary>
/// 加密
/// </summary>
/// <param name="text">加密文本</param>
/// <param name="skey">密钥</param>
/// <returns></returns>
static string Encrypt(string text, string skey)
{
    var bKey = Encoding.UTF8.GetBytes(skey);

    using var aesAlg = Aes.Create();
    using var encryptor = aesAlg.CreateEncryptor(bKey, aesAlg.IV);
    using var msEncrypt = new MemoryStream();
    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write, true))
    using (var swEncrypt = new StreamWriter(csEncrypt, leaveOpen: true))
    {
        swEncrypt.Write(text);
    }

    var bVector = aesAlg.IV;
    var dataLength = bVector.Length + (int)msEncrypt.Length;
    var decryptedContent = msEncrypt.GetBuffer();
    var base64Length = Base64.GetMaxEncodedToUtf8Length(dataLength);
    var result = new byte[base64Length];

    Unsafe.CopyBlock(ref result[0], ref bVector[0], (uint)bVector.Length);
    Unsafe.CopyBlock(ref result[bVector.Length], ref decryptedContent[0], (uint)msEncrypt.Length);
    Base64.EncodeToUtf8InPlace(result, dataLength, out base64Length);

    return Encoding.ASCII.GetString(result.AsSpan()[..base64Length]);
}

/// <summary>
/// 解密
/// </summary>
/// <param name="hash">加密后字符串</param>
/// <param name="skey">密钥</param>
/// <returns></returns>
 static string Decrypt(string hash, string skey)
{
    var fullCipher = Convert.FromBase64String(hash);

    var bVector = new byte[16];
    var cipher = new byte[fullCipher.Length - bVector.Length];

    Unsafe.CopyBlock(ref bVector[0], ref fullCipher[0], (uint)bVector.Length);
    Unsafe.CopyBlock(ref cipher[0], ref fullCipher[bVector.Length], (uint)(fullCipher.Length - bVector.Length));
    var bKey = Encoding.UTF8.GetBytes(skey);

    using var aesAlg = Aes.Create();
    using var decryptor = aesAlg.CreateDecryptor(bKey, bVector);
    using var msDecrypt = new MemoryStream(cipher);
    using var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
    using var srDecrypt = new StreamReader(csDecrypt);

    return srDecrypt.ReadToEnd();
}

static string CalculateMD5Hash(string input)
{
    // 使用MD5创建一个MD5CryptoServiceProvider实例
    using (MD5 md5 = MD5.Create())
    {
        // 将输入字符串转换为字节数组并计算其哈希值
        byte[] inputBytes = Encoding.ASCII.GetBytes(input);
        byte[] hashBytes = md5.ComputeHash(inputBytes);

        // 将得到的字节数组转换为十六进制的字符串
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hashBytes.Length; i++)
        {
            sb.Append(hashBytes[i].ToString("X2"));
        }

        // 返回十六进制字符串
        return sb.ToString();
    }
}