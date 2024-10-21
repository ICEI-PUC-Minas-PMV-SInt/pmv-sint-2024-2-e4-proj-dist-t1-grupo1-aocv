import { createBrowserRouter, RouterProvider } from "react-router-dom"
import { Agenda } from "./Paginas/Agenda"
import EsqueceuSenha from "./Paginas/RecuperarSenha"
import Viagens from "./Paginas/Viagens"
import { PaginaInicial } from "./Paginas/Home/Home"



const router = createBrowserRouter([
  {
    path: "/agenda",
    element: <Agenda/>
  },
  {
    path: "/recuperar_senha",
    element: <EsqueceuSenha/>
  },
  {
    path: "/viagens",
    element: <Viagens/>
  },
  {
    path: "",
    element: <PaginaInicial/>
  },
 
])

export function App() {
  return <RouterProvider router={router} />
}
