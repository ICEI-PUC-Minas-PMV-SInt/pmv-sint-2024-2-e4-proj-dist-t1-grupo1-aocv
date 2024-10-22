import React, { useState } from 'react';
import './style.css';


const PlanosViagem = () => {
  const [viagens, setViagens] = useState([]);
  const [novoPlano, setNovoPlano] = useState({
    destino: '',
    dataInicio: '',
    dataFim: '',
    descricao: ''
  });

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setNovoPlano({ ...novoPlano, [name]: value });
  };

  const adicionarPlano = (e) => {
    e.preventDefault();
    setViagens([...viagens, novoPlano]);
    setNovoPlano({ destino: '', dataInicio: '', dataFim: '', descricao: '' });
  };

  return (
    <>
    
    <div className="planos-viagem-container">
      <h1>Planos de Viagem</h1>
      <form className="form-viagem" onSubmit={adicionarPlano}>
        <div className="form-group">
          <label htmlFor="destino">Destino</label>
          <input
            type="text"
            id="destino"
            name="destino"
            value={novoPlano.destino}
            onChange={handleInputChange}
            required
          />
        </div>

        <div className="form-group">
          <label htmlFor="dataInicio">Data de Início</label>
          <input
            type="date"
            id="dataInicio"
            name="dataInicio"
            value={novoPlano.dataInicio}
            onChange={handleInputChange}
            required
          />
        </div>

        <div className="form-group">
          <label htmlFor="dataFim">Data de Fim</label>
          <input
            type="date"
            id="dataFim"
            name="dataFim"
            value={novoPlano.dataFim}
            onChange={handleInputChange}
            required
          />
        </div>

        <div className="form-group">
          <label htmlFor="descricao">Descrição</label>
          <textarea
            id="descricao"
            name="descricao"
            value={novoPlano.descricao}
            onChange={handleInputChange}
            rows="4"
            placeholder="Detalhes sobre a viagem"
          ></textarea>
        </div>

        <button type="submit" className="btn-adicionar">Adicionar Plano</button>
      </form>

      <div className="lista-viagens">
        <h2>Minhas Viagens</h2>
        {viagens.length === 0 ? (
          <p>Nenhum plano de viagem adicionado ainda.</p>
        ) : (
          <ul>
            {viagens.map((viagem, index) => (
              <li key={index}>
                <h3>{viagem.destino}</h3>
                <p>
                  {viagem.dataInicio} até {viagem.dataFim}
                </p>
                <p>{viagem.descricao}</p>
              </li>
            ))}
          </ul>
        )}
      </div>
    </div>
    </>
  );
};

export default PlanosViagem;
