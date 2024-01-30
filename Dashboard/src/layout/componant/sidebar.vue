<template>
    <SidebarMenu :menu="menu" disableHover hideToggle theme="white-theme" @item-click="onItemClick" class="layout-sideBar" />

  </template>

<script setup lang="ts">
import { useRouter } from 'vue-router';
import {ref} from 'vue'
import { SidebarMenu } from 'vue-sidebar-menu'
import 'vue-sidebar-menu/dist/vue-sidebar-menu.css'
const router = useRouter()

const menu  = ref([
          {
           
          },
          
          {
           
            title: 'home',
            icon: 'fa fa-user',
          },
          {
          
            title: 'about',
            icon: 'fa fa-chart-area',
            child: [
              {
                title: 'login',
              },
            ],
          },
          {
          
            title: 'users',
            icon: 'fa fa-chart-area',

          },
        ],)

        const onItemClick = (event:any,item:any)=>{

          router.push(`./${item.title}`)
        }

   
</script>


<style scoped>
.layout-sideBar{
  position: fixed;
    width: 300px;
    height: calc(100vh - 8rem);
    z-index: 999;
    overflow-y: auto;
    overflow-x: hidden;
    top: 5rem;
    left: 2rem;
    color: aqua;
}

</style>