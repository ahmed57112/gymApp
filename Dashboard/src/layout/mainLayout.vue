<!-- Layout.vue -->
<template>

<topBar @togelSideBar="togelSideBar"></topBar>

  <div class="grid grid-cols-12" style="padding-top: 5rem;">

    <div  :class="leftGrid" style="padding-right: 6rem;">

      <sidebar :collapsed="collapsed"></sidebar>
    </div>

    <div :class="rightGrid" style="background-color: aqua; margin-left: 1rem; margin-right: 2rem;">
      <router-view></router-view>
    </div>
  </div>
</template>

<script setup lang="ts">
import topBar from './componant/topBar.vue';
import sidebar from './componant/sidebar.vue';
import { ref } from 'vue';
const collapsed = ref(false)
const leftGrid = ref("col-span-3")
const rightGrid = ref("col-span-9")
const togelSideBar = (state:boolean)=>{
  collapsed.value = state

  if(state == true){
    leftGrid.value ="col-span-1"
    rightGrid.value ="col-span-11"

  }
  else{
    leftGrid.value ="col-span-3"
    rightGrid.value ="col-span-9"
  }

}


</script>

<style scoped>
/* Your styles for the layout component go here */



.col-span-3.hidden {
  display: none;
}


</style>
