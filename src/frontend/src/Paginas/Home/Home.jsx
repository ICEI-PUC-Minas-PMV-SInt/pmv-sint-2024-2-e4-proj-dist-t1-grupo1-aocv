import React from 'react';

export function PaginaInicial(){
    return (
        <div className="flex flex-col items-center min-h-screen">
            <div className="mt-20 max-w-4xl mx-5">
                <h1 className="text-9xl font-bold mb-6 text-center">Timely</h1>
                <p className="text-2xl mt-4 mb-20 text-justify">
                O Timely é mais do que apenas um aplicativo de agenda, é seu copiloto pessoal para uma vida mais organizada e produtiva. Imagine ter todos os seus compromissos, tarefas e planos de viagem centralizados em um só lugar, acessíveis a qualquer hora e em qualquer dispositivo. Com o Timely, você não apenas gerencia seu tempo, mas também descobre novas oportunidades e otimiza suas jornadas. Seja para planejar suas férias dos sonhos ou para organizar sua rotina agitada, o Timely simplifica sua vida e te ajuda a alcançar seus objetivos com mais eficiência.

</p>
            </div>
            <div className="flex flex-grow items-center justify-center -mt-20">
                <div className="flex flex-col space-y-6">
                    <a
                        href="login"
                        className="bg-gray-800 text-white text-3xl w-80 px-10 py-8 rounded-md hover:bg-gray-700 text-center"
                    >
                        Login
                    </a>
                    <a
                        href="cadastro"
                        className="bg-gray-800 text-white text-3xl w-80 px-10 py-8 rounded-md hover:bg-gray-700 text-center"
                    >
                        Cadastre-se
                    </a>
                </div>
            </div>
        </div>
    );
};
