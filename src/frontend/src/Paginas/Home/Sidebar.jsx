import React from 'react';
import './style.css';

const Sidebar = () => {
    return (
        <div className="sidebar">
            <h2 className="sidebar-title">Timely</h2>
            <ul className="sidebar-links">
                <li><a href="/home">Home</a></li>
                <li><a href="/agenda">Agenda</a></li>
                <li><a href="/viagens">Viagens</a></li>
                <li><a href="/recuperar_senha">Recuperar Senha</a></li>
                <li><a href="/sobre-nos">Sobre N�s</a></li>
            </ul>
        </div>
    );
};

export default Sidebar;