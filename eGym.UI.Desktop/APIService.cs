using eGym.UI.Desktop.Properties;
using Flurl.Http;
using Stripe;
using System.Text;

namespace eGym.UI.Desktop
{
    public class APIService
    {
        private string _resource = null;
        public string _endpoint = "";

        public static string Username = null;
        public static string Password = null;

        public APIService(string resource)
        {
            _resource = resource;

            string getEnv = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (getEnv == "Development") 
            {
                _endpoint = Settings.Default.APIUrlLocal;
            }
            if (getEnv == "Production")
            {
                _endpoint = Settings.Default.APIUrlProduction;
            }
        } 

        public async Task<T> Login<T>(object request, string path = "")
        {
            try
            {
                var query = "";
                if (request != null)
                {
                    query = await request.ToQueryString();
                }

                var result = await $"{_endpoint}{_resource}{path}?{query}".PostAsync().ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                    return default(T);
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<IFlurlResponse> Post(object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}".WithBasicAuth(Username, Password).PostJsonAsync(request);
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if(ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                    return default;
                }
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> Get<T>(object search = null, string path = "")
        {
            try
            {
                var query = "";
                if (search != null)
                {
                    query = await search.ToQueryString();
                }

                string url = $"{_endpoint}{_resource}{path}";
                if (search != null)
                {
                    url += $"?{query}";
                }

                var list = await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return list;
            }
            catch(FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                    return default(T);
                }

                return default;
            }
        }

        public async Task<T> GetById<T>(int id)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}?id={id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                    return default(T);
                }

                return default;
            }
        }

        public async Task<IFlurlResponse> Put(object id, object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}?id={id}".WithBasicAuth(Username, Password).PutJsonAsync(request);

                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                    return default;
                }

                return default;
            }
        }

        public async Task<IFlurlResponse> Put(object id, string path = "")
        {
            try
            {
                var result = await $"{_endpoint}{_resource}{path}?reservationId={id}".WithBasicAuth(Username, Password).PutAsync();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                    return default;
                }

                return default;
            }
        }

        public async Task<IFlurlResponse> Delete(object id)
        {
            try
            {
                var query = await id.ToQueryString();

                var result = await $"{_endpoint}{_resource}?{query}".WithBasicAuth(Username, Password).DeleteAsync();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                    return default;
                }

                return default;
            }
        }
    }
}
