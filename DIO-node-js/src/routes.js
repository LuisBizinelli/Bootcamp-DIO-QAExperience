import { Router } from "express";

const routes = Router()

const database = ['Luis']

routes.get('/users', (request, response) => {
    return response.status(200).json(database)
})


routes.post('/users', (request, response) => {
    const { name } = request.body
    database.push(name)
    return response.status(201).json({'mensagem': 'User ${name} criado'}) 
} )
// GET - Leitura de dados
// POST - Criação de dados
// PUT/PATCH - Edição de dados
// DELETE - Deletar dados

export { routes }