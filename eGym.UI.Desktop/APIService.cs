using eGym.UI.Desktop.Properties;
using Flurl.Http;
using Stripe;
using System.Text;

namespace eGym.UI.Desktop
{
    public class APIService
    {
        private string _resource = null;
        public static string _endpoint = Settings.Default.APIUrl;

        public static string Username = null;
        public static string Password = null;

        public APIService(string resource)
        {
            _resource = resource;
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

        public async Task<T> Post<T>(object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}".WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if(ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
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

        public async Task<T> Post<T>(object request, string path = "")
        {
            try
            {
                var query = "";
                if (request != null)
                {
                    query = await request.ToQueryString();
                }

                var result = await $"{_endpoint}{_resource}{path}?{query}".WithBasicAuth(Username, Password).PostAsync().ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
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

        public async Task Get(string path)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}/{path}".WithBasicAuth(Username, Password).GetAsync();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                }

                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var list = await $"{_endpoint}{_resource}{path}?{query}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return list;
            }
            catch(FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                }

                return default;
            }
        }

        public async Task<T> GetById<T>(int id)
        {
            var result = await $"{_endpoint}{_resource}?id={id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

            return result;
        }

        public async Task<T> Put<T>(object id, object request)
        {
            var result = await $"{_endpoint}{_resource}?id={id}".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

            return result;
        }

        public async Task<T> Put<T>(object id, string path = "")
        {
            var result = await $"{_endpoint}{_resource}{path}?reservationId={id}".WithBasicAuth(Username, Password).PutAsync().ReceiveJson<T>();

            return result;
        }

        public async Task Delete(object id)
        {
            try
            {
                var query = await id.ToQueryString();

                var result = await $"{_endpoint}{_resource}?{query}".WithBasicAuth(Username, Password).DeleteAsync();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.StatusCode == 403)
                {
                    MessageBox.Show("Nemate pravo pristupa");
                }
            }
        }
    }
}
