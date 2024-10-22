import React from 'react';
import './style.css';
import Sidebar from './Sidebar';

export function PaginaInicial(){
    return (
        <>
        <Sidebar/>
        
             <div class="content">
               <h1 className='texto-principal'>Timely</h1>
               
               <p className='texto-segundo'><em>O Timely é mais do que apenas um aplicativo de agenda, é seu copiloto pessoal para uma vida mais organizada e produtiva. Imagine ter todos os seus compromissos, tarefas e planos de viagem centralizados em um só lugar, acessíveis a qualquer hora e em qualquer dispositivo. Com o Timely, você não apenas gerencia seu tempo, mas também descobre novas oportunidades e otimiza suas jornadas. Seja para planejar suas férias dos sonhos ou para organizar sua rotina agitada, o Timely simplifica sua vida e te ajuda a alcançar seus objetivos com mais eficiência.</em></p>
             </div>
        
        </>
    );
};
