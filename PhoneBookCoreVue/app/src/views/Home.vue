<template>
  <b-container>
    <b-row>
      <b-col>
        <ContactsTable />
      </b-col>
      <b-col>
        <InputForm />
      </b-col>
    </b-row>
  </b-container>
</template>

<script>
  // @ is an alias to /src
  import ContactsTable from '@/components/ContactsTable.vue';
  import InputForm from '@/components/InputForm.vue';

  export default {
    name: 'Home',
    components: {
      ContactsTable,
      InputForm
    }
  }
</script>
