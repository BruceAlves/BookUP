FROM node:18-alpine AS build
WORKDIR /app

COPY package*.json ./

# Instala dependências
RUN npm install

# Corrige o esbuild para a versão esperada (force = substitui o binário corrompido ou errado)
RUN npm install esbuild@0.25.5 --force

COPY . .

RUN npm run build

FROM nginx:stable-alpine
COPY --from=build /app/dist /usr/share/nginx/html
