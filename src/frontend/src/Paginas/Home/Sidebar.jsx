import React from 'react'
import './style.css';


export default function Sidebar() {
  return (
    <>
    <div className="sidebar">
       <a  className="active" href="home">Home</a>
       <a href="login">Login</a>
       <a href="recuperar_senha">recuperar senha</a>
       <a href="agenda">agenda</a>
       <a href="viagens">viagens</a>
       <a href="#">About</a>
    </div>
    </>
  )
}