import { CriarCompromisso } from "./criar-atividade-modal"
import { Plus } from "lucide-react";
import { useState } from "react";
import { Compromisso } from "./compromissos";

export function Agenda(){
    const [isCreateCompromissoModalOpen, setIsCreateCompromissoModalOpen] = useState(false)

    function openCreateCompromissoModal() {
        setIsCreateCompromissoModalOpen(true)
    }

    function closeCreateCompromissoModal() {
        setIsCreateCompromissoModalOpen(false)
    }

    return (
        <div className="max-w-6xl px-6 py-10 mx-auto space-y-8">
          <main className="flex gap-16 px-4">
            <div className="flex-1 space-y-6">
              <div className="flex items-center justify-between">
                <h2 className="text-3xl font-semibold">Compromissos</h2>
    
                <button onClick={openCreateCompromissoModal} className="bg-lime-300 text-lime-950 rounded-lg px-5 py-2 font-medium flex items-center gap-2 hover:bg-lime-400">
                  <Plus className="size-5" />
                  Cadastrar compromisso
                </button>
              </div>
    
              <Compromisso />
            </div>
          </main>
    
          {isCreateCompromissoModalOpen && (
            <CriarCompromisso 
              closeCreateCompromissoModal={closeCreateCompromissoModal}
            />
          )}
        </div>
      )
}


