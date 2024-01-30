<template>
    <div class="topBar w-full">
        <Toolbar  style="background-color: #fff;">
            <template #start>
                <button class="p-link layout-menu-button layout-topbar-button" @click="togeleSideBar">
            <i class="pi pi-bars"></i>
        </button>
      
            </template>
            <template #center>
                logo
    
            </template>



      

            <template #end>
                <div class="flex flex-wrap align-items-center gap-6 pr-10">
                    <button class="p-link inline-flex justify-content-center align-items-center text-black h-3rem w-3rem border-circle hover:bg-white-alpha-10 transition-all transition-duration-200"><i class="pi pi-home text-2xl"></i></button>
                    <button class="p-link inline-flex justify-content-center align-items-center text-black h-3rem w-3rem border-circle hover:bg-white-alpha-10 transition-all transition-duration-200"><i class="pi pi-user text-2xl"></i></button>
                </div>
            </template>
        </Toolbar>
    </div>
</template>



<script setup lang="ts">

import Toolbar from 'primevue/toolbar';


import {ref} from 'vue'
const emit = defineEmits(['togelSideBar'])


const sideBarTogelStat = ref(false)
const togeleSideBar = ()=>{
emit("togelSideBar",!sideBarTogelStat.value)
sideBarTogelStat.value = !sideBarTogelStat.value

}



</script>
<style scoped>
.topBar{
    position:fixed;
    z-index: 997;
    height: 5rem;
    left: 0;
    top: 0;
    padding: 0 2rem;


    
}
</style>



