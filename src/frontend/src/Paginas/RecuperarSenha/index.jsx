import { useForm } from 'react-hook-form';
import './style.css';
import Sidebar from '../Home/Sidebar';


export default function EsqueceuSenha() {
    
  const { register, handleSubmit, watch, formState: { errors } } = useForm();
  const onSubmit = data => console.log(data);

  console.log(watch("email")); // watch input value by passing the name of it

  return (
    <> 
    <Sidebar/>
    
      <div className="grid-container">
        <div>
          <h1>Esqueceu a palavra-passe</h1>
                <form onSubmit={handleSubmit(onSubmit)}>
                 {/* register your input into the hook by invoking the "register" function */}
                 <input  {...register("email", { required: true } ) } placeholder="Email" className=""/>
                 <p>Enviaremos um código de verificação para este e-mail se ele corresponder a uma conta existente. </p>

                 {/* errors will return when field validation fails  */}
                 {errors.email && <p>This field is required</p>}
      
                  <p><input type="submit" value="Enviar" className=""/></p>
                 </form>
                 <a href="home"> voltar</a>
            </div>
       </div>
    </>
  );
}