import React from 'react';

const Navbar = () => {
    return (
        <nav className="w-full bg-zinc-900 py-6 text-zinc-50">
            <div className="max-w-full flex justify-between items-center px-8">
                <a href="/" className="text-2xl font-semibold hover:no-underline">
                    Timely
                </a>
                <ul className="flex space-x-6">
                    <li><a href="login" className="hover:no-underline">Login</a></li>
                    <li><a href="cadastro" className="hover:no-underline">Cadastre-se</a></li>
                </ul>
            </div>
        </nav>
    );
};

export default Navbar;
