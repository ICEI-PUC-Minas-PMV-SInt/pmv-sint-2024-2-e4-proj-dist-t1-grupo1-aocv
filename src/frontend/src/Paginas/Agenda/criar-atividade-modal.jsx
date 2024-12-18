import { Calendar, Tag, X } from "lucide-react";


export function CriarCompromisso({closeCreateCompromissoModal}){
    
    
    
    return (
        <div className="fixed inset-0 bg-black/60 flex items-center justify-center">
          <div className="w-[640px] rounded-xl py-5 px-6 shadow-shape bg-zinc-900 space-y-5">
            <div className="space-y-2">
              <div className="flex items-center justify-between">
                <h2 className="font-lg font-semibold">Cadastrar Compromisso</h2>
                <button>
                  <X className="size-5 text-zinc-400" onClick={closeCreateCompromissoModal} />
                </button>
              </div>
            </div>
            
            <form  className="space-y-3">
              <div className="h-14 px-4 bg-zinc-950 border border-zinc-800 rounded-lg flex items-center gap-2">
                <Tag className="text-zinc-400 size-5" />
                <input
                  name="title"
                  placeholder="Qual a atividade?"
                  className="bg-transparent text-lg placeholder-zinc-400 outline-none flex-1"
                />
              </div>
              
              <div className="h-14 px-4 bg-zinc-950 border border-zinc-800 rounded-lg flex items-center gap-2">
                <Tag className="text-zinc-400 size-5" />
                <input
                  name="descricao"
                  placeholder="Conte mais detalhes"
                  className="bg-transparent text-lg placeholder-zinc-400 outline-none flex-1"
                />
              </div>
    
              <div className="h-14 flex-1 px-4 bg-zinc-950 border border-zinc-800 rounded-lg flex items-center gap-2">
                <Calendar className="text-zinc-400 size-5" />
                <input
                  type="datetime-local"
                  name="occurs_at"
                  placeholder="Data e horário da atividade"
                  className="bg-transparent text-lg placeholder-zinc-400 outline-none flex-1"
                />
              </div>
    
              <button className="bg-lime-300 text-lime-950 rounded-lg px-5 py-2 font-medium flex items-center gap-2 hover:bg-lime-400" >
                Salvar compromisso
              </button>
            </form>
          </div>
        </div>
      )
    }