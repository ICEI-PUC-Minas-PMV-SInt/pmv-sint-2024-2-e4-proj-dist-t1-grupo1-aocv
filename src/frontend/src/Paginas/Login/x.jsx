import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';

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
    <main className="container mx-auto text-center my-10">
      <form className="w-80 mx-auto" onSubmit={handleSubmit}>
        <div className="mb-4">
          <input
            type="email"
            className="w-full px-3 py-2 border rounded"
            placeholder="Email"
            value={email}
            onChange={(e) => setEmail(e.target.value)}
            autoComplete="email"
          />
        </div>
        <div className="mb-4 relative">
          <input
            type={showPassword ? "text" : "password"}
            className="w-full px-3 py-2 border rounded"
            placeholder="Senha"
            value={password}
            onChange={(e) => setPassword(e.target.value)}
            autoComplete="current-password"
          />
          <div className="absolute right-3 top-3">
            <input
              type="checkbox"
              checked={showPassword}
              onChange={() => setShowPassword(!showPassword)}
            />
            <label className="ml-2">Exibir senha</label>
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
          <a href="/public/forgot-password" className="text-blue-500">Esqueceu a senha?</a>
        </div>
      </form>
    </main>
  );
}

export default LoginPage;