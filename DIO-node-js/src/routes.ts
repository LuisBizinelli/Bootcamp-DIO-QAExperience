import { Router } from "express";
import { UsersController } from "./controllers/usersController";

const routes = Router()
const usersController = new UsersController()


routes.get('/users', usersController.listarUsuario)

routes.post('/users', usersController.criarUsuario)
// GET - Leitura de dados
// POST - Criação de dados
// PUT/PATCH - Edição de dados
// DELETE - Deletar dados

export { routes }