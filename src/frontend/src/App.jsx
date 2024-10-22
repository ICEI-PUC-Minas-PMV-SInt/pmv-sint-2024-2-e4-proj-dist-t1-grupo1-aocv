import { createBrowserRouter, RouterProvider } from "react-router-dom"
import { Agenda } from "./Paginas/Agenda"
import EsqueceuSenha from "./Paginas/RecuperarSenha"
import Viagens from "./Paginas/Viagens"
import { PaginaInicial } from "./Paginas/Home/Home"
import LoginPage from "./Paginas/Login"


const router = createBrowserRouter([
  {
    path: "/login",
    element: <LoginPage/>
  },
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
  {
    path: "home",
    element: <PaginaInicial/>
  },
 
])

export function App() {
  return <RouterProvider router={router} />
}
