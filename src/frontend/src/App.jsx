import { createBrowserRouter, RouterProvider } from "react-router-dom"
import { Agenda } from "./Paginas/Agenda"
import EsqueceuSenha from "./Paginas/RecuperarSenha"
import Viagens from "./Paginas/Viagens"



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
])

export function App() {
  return <RouterProvider router={router} />
}
