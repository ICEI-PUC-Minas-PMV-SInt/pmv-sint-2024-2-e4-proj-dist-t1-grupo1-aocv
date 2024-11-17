import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Sidebar from '../Home/Sidebar';


function LoginPage() {
  const navigate = useNavigate();
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [showPassword, setShowPassword] = useState(false);
  const [isLoading, setIsLoading] = useState(false);

  const isFormValid = () => email && password;

  const handleSubmit = async (event) => {
    event.preventDefault();
    setIsLoading(true);
    try {
      const response = await fetch('https://api.projeto.com/login', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({ email, password }),
        credentials: 'include'
      });

      const responseData = await response.json();
      if (response.ok) {
        navigate("/?");
      } else {
        alert(responseData.message);
      }
    } catch (error) {
      alert(`Ocorreu um erro: ${error.message}`);
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <>
          <Sidebar />
          <h1 className="text-9xl font-bold mb-44">Timely</h1>
          <h2 className="text-4xl font-bold mb-12 text-center">Login</h2>
    <main className="container ">
      <form className="w-80 mx-auto" onSubmit={handleSubmit}>
        <div className="mb-4">
          <input
            type="email"
            className="w-full px-3 py-2 border rounded text-black"
            placeholder="Email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            autoComplete="email"
          />
        </div>
                  <div className="mb-4 relative">
                      <input
                          type={showPassword ? "text" : "password"}
                          className="w-80 px-3 py-2 border rounded text-black"
                          placeholder="Senha"
                          value={password}
                          onChange={(e) => setPassword(e.target.value)}
                          autoComplete="current-password"
                      />
                      <div className="absolute right-0 top-0 flex items-center h-full pr-3">
                      </div>
                  </div>

        <button
          type="submit"
          className={`w-full py-2 text-white rounded ${isLoading ? 'bg-gray-500' : 'bg-green-500'}`}
          disabled={!isFormValid() || isLoading}
        >
          {isLoading ? "Carregando..." : "ENTRAR"}
        </button>
                  <div className="mt-4">
                      <a
                          href="/recuperar_senha"
                          className="block w-full text-center py-2 text-white bg-blue-500 rounded hover:bg-blue-600"
                            >Esqueceu a senha?
         </a>
      </div>
      </form>
    </main>
    </>
  );
}

export default LoginPage;