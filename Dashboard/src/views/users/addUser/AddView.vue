
<template>
    <div class="card">
        <TabView>
            <TabPanel header="البيانات الاساسيه">
                <profileView></profileView>
            </TabPanel>
            <TabPanel header="الجدول الغذائى">
                y
            </TabPanel>
            <TabPanel header="جدول التمرين">
                z
            </TabPanel>
        </TabView>
    </div>
</template>


  

<script setup lang="ts">
import TabView from 'primevue/tabview';
import TabPanel from 'primevue/tabpanel';

import profileView from './componant/profileView.vue'


</script>
  <style>
  
  </style>
  