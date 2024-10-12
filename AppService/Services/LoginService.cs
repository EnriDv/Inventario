public class LoginService
    {
        private Dictionary<string, string> _usuarios = new Dictionary<string, string>();

        public LoginService()
        {
            _usuarios.Add("usuario1", "contraseña1");
            _usuarios.Add("usuario2", "contraseña2");
        }

        public bool Autenticar(string username, string password)
        {
            if (_usuarios.TryGetValue(username, out var storedPassword))
            {
                return storedPassword == password;
            }
            return false;
        }
    }
