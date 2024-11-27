import React from 'react'

export default function Api() {
    const handleGetData = async () => {
        const userDate = await fetch('http://localhost:5173/api/Agenda/1');
        const userResponse = await userDate.json();
        console.log(userResponse);
    }

    return (
        <div>
            <button onClick={handleGetData}>
                Testa backend
            </button>
        </div>
    )
}
