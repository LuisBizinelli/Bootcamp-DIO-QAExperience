import express from 'express';

const server = express();

server.listen(5000, () => {
    console.log('servidor esta on na porta 5000!')
})