import { useForm } from 'react-hook-form';
import './style.css';
import Sidebar from '../Home/Sidebar';

export default function EsqueceuSenha() {
    const { register, handleSubmit, watch, formState: { errors } } = useForm();
    const onSubmit = data => console.log(data);

    console.log(watch("email"));

    return (
        <>
            <Sidebar />
            <main className="container">
                <h1 className="text-9xl font-bold mb-10 text-center">Timely</h1>
                <div className="form-container mx-auto max-w-lg bg-white p-6 rounded shadow">
                    <h2 className="font-bold text-xl mb-4 text-center text-black">Recuperar senha</h2>
                    <form onSubmit={handleSubmit(onSubmit)} className="space-y-4">
                        <div>
                            <input
                                {...register("email", { required: true })}
                                placeholder={errors.email ? "Preencha seu E-mail" : "E-mail"}
                                className={`input text-black w-full px-4 py-2 border rounded ${errors.email ? "border-red-500" : "border-gray-300"}`}
                            />
                            {errors.email && (
                                <p className="text-red-500 text-sm mt-1">Este campo é obrigatório.</p>
                            )}
                        </div>
                        <p className="text-gray-600 text-sm mb-4">
                            Enviaremos um código de verificação para seu E-mail.
                        </p>
                        <div className="flex flex-col items-center space-y-4">
                            <input
                                type="submit"
                                value="Enviar"
                                style={{
                                    backgroundColor: "#4CAF50",
                                    color: "white",
                                    padding: "12px 24px",
                                    borderRadius: "8px",
                                    cursor: "pointer"
                                }}
                            />
                            <a
                                href="/"
                                className="bg-gray-500 text-white px-6 py-2 rounded cursor-pointer hover:bg-gray-700 transition"
                            >
                                Voltar
                            </a>
                        </div>
                    </form>
                </div>
            </main>
        </>
    );
}
