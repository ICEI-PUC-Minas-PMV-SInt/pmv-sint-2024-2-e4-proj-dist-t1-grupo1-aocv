import { createBrowserRouter, RouterProvider } from "react-router-dom"
import { Agenda } from "./Paginas/Agenda"
import EsqueceuSenha from "./Paginas/RecuperarSenha"



const router = createBrowserRouter([
  {
    path: "/agenda",
    element: <Agenda/>
  },
  {
    path: "/recuperar_senha",
    element: <EsqueceuSenha/>
  },
])

export function App() {
  return <RouterProvider router={router} />
}