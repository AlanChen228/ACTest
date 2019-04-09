using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyWebAPI.Models;
using System.Text;
using Jose;

namespace MyWebAPI.Controllers
{
    public class TokenController : ApiController
    {
        // POST api/values
        public object Post(LoginData loginData)
        {
            // TODO: key應該移至config
            var secret = "wellwindJtwDemo";

            // TODO: 真實世界檢查帳號密碼
            if (loginData.Username == "wellwind" && loginData.Password == "1234")
            {
                var payload = new JwtAuthObject()
                {
                    Id = "wellwind"
                };

                return new
                {
                    Result = true,
                    token = Jose.JWT.Encode(payload, Encoding.UTF8.GetBytes(secret), JwsAlgorithm.HS256)
                };
            }
            else
            {
                throw new UnauthorizedAccessException("帳號密碼錯誤");
            }
        }
    }
}
